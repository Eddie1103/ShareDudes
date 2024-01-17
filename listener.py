#!/usr/bin/python
import psycopg2
import common
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
    data.get('username'),
    data.get('password'),
    ]

    result = 'false'
    if(database.customCommand(database, 'select password from users where username=', values[0]) == common.hashPassword(values[1])):
        result = 'true'

    return jsonify({"result":result})

@app.route('/createuser', methods=['POST'])
def createUser():
    
    #if request.method  == 'OPTIONS':
     #   return buildResponse()

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

    return jsonify({"result":database.createUser(database, values)})

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
def addinserate():

    sqlresult = database.customCommand(database, 'select * from offer_types')

    result = ''

    for x in sqlresult:
        print(x)
        if x[1] != sqlresult[0][1]:
            result+=','
        result+=f"'result':'{x[1]}'"

    return jsonify(result)


@app.route('/', methods=['POST', 'GET'])
def huansohn():
    return jsonify({"result": "fick dich!"})

'''
def buildResponse():
    response = Flask.make_response(Flask, str(200))
    response.headers.add("Access-Control-Allow-Origin", "*")
    response.headers.add("Access-Control-Allow-Header", "*")
    response.headers.add("Access-Control-Allow-Methods", "*")
    return response
'''

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5000)
    

    #get userinformation

    #createuser

    #customcommand