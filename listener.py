#!/usr/bin/python
import base64
import common
import io
from PIL import Image
from database import Database
from flask import Flask, request, jsonify
from flask_cors import CORS


database = Database.create()

app = Flask(__name__)
CORS(app)

@app.route('/login', methods=['POST'])
def login():
    
    data = request.json
    values=[
    data.get('email'),
    data.get('password'),
    ]

    result = 'false'

    print('email:' + str(values[0]))

    sqlresult = database.customCommand(database, "select user_id, password from users where email_address='"+str(values[0]) + "'")[0]

    
    print('db:' + sqlresult[1])
    hashedpsw = common.hashPassword(values[1])

    print(hashedpsw)

    if(sqlresult[1] == hashedpsw):
        result = 'true'

    print('login: ' + result)
    return jsonify({'result': result, "userid":sqlresult[0]})

@app.route('/createuser', methods=['POST'])
def createUser():

    data = request.json
    values=[
    data.get('username'),
    data.get('password'),
    data.get('email_address'),
    data.get('birthdate'),
    data.get('is_admin'),
    
    data.get('street'),
    data.get('streetNumber'),
    data.get('postalCode'),
    data.get('city'),
    data.get('state'),
    ]

    print("createuser POST")

    return jsonify({"userid":database.createUser(database, values)})

@app.route('/select', methods=['POST', 'GET'])
def select():
    condition = ""

    if request.method  == 'POST':
        data = request.json
        condition = data.get('values')
        print("select POST:values ->", condition)
    else:
        print("select GET")

    #condition(where id=2 | where username='Henry')
    return jsonify({"result": database.select(database, condition)})


@app.route('/getoffertypes', methods=['GET'])
def getoffertypes():

    sqlresult = database.customCommand(database, 'select * from offer_types order by offer_type_id')

    result = []

    for type in sqlresult:
        result+={"id": type[0], "value": type[1]},

    return jsonify(result)


@app.route('/addinserate', methods=['POST'])
def addinserate():

    data = request.json
    values=[
    data.get('title'),
    data.get('text'),
    data.get('user_id'),
    data.get('address_id'),
    data.get('offer_type_id'),
    data.get('image_base64')
    ]

    database.customCommandInsert(database, "insert into offers(title, text, user_id, address_id, offer_type_id) values('" + values[0] + "','" + values[1] + "'," + values[2] + "," + values[3] + "," + values[4] + ")")
    sqlresult = database.customCommand(database, 'select offer_id from offers order by offer_id DESC LIMIT 1')

    path = f'/var/www/html/pictures/inserate/{sqlresult[0][0]}.png'

    base64string = values[5]
    cuttedshit = base64string.split(',')
    print(cuttedshit[0])
    imgdata = base64.b64decode(cuttedshit[1])
    

    with open(path, 'wb') as writer:
        writer.write(imgdata)
        writer.close()

    return jsonify({"result" : sqlresult[0]})

@app.route('/getinserate', methods=['GET'])
def getinserate():
    
    sqlresult = database.customCommand(database, 'SELECT * FROM offers;')

    result = []

    for type in sqlresult:
        result+={"id": type[0], "title": type[1], 'text': type[2]},

    return jsonify(result)

@app.route('/getmainaddressid', methods=['GET'])
def getmainaddressid():
    data = request.json
    values=[
        data.get('user_id')
    ]

    sqresult = database.customCommand(database, 'select address_id where user_id=' + values[0] + ' AND is_main=true')

    return jsonify(sqresult[0])

@app.route('/getaddresses', methods=['POST'])
def getaddresses():
    data = request.json
    values=[
        data.get('user_id')
    ]

    sqlresult = database.customCommand(database, 'select * from address where user_id=' + values[0])

    result = []

    for type in sqlresult:
        result+={"id": type[0], "value": str(type[2]) + " " + str(type[3])+ ", " + str(type[6]) + " " + str(type[4])},

    return jsonify(result)

@app.route('/', methods=['POST', 'GET'])
def huansohn():
    return jsonify({"result": "fick dich!"})

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5000)
