#!/usr/bin/python
import psycopg2
from database import Database
from flask import Flask, request, jsonify
from flask_cors import CORS


DATABASE = Database.create()

app = Flask(__name__)
CORS(app)

@app.route('/createuser', methods=['POST'])
def testget():
    
    data = request.json
    values=[
    data.get('username'),
    data.get('password'),
    data.get('email_address'),
    data.get('banned'),
    data.get('birthdate'),
    data.get('is_admin'),
    ]

    print(values[0])
    print(values[1])
    print(values[2])
    print(values[3])
    print(values[4])
    print(values[5])
    print(values[6])

    print("createuser POST")

    return jsonify({"result":DATABASE.createUser(DATABASE, values)})

@app.route('/select', methods=['POST', 'GET'])
def select():
    condition = ""

    if request.method  == 'POST':
        data = request.json
        condition = data.get('values')
        print("select POST:values ->", condition)
    else:
        condition = "where id>0"
        print("select GET")

    #condition(where id=2 | where username='Henry')
    return jsonify({"result": DATABASE.select(DATABASE, condition)})

@app.route('/', methods=['POST', 'GET'])
def huansohn():
    return jsonify({"result": "fick dich!"})

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5000)
    

    #get userinformation

    #createuser

    #customcommand