#!/usr/bin/python
import psycopg2
from database import Database
from flask import Flask, request, jsonify
from flask_cors import CORS


database = Database.create()

app = Flask(__name__)
CORS(app)

@app.route('/createuser', methods=['POST'])
def testget():
    
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
    return jsonify({"result": database.select(condition)})

@app.route('/', methods=['POST', 'GET'])
def huansohn():
    return jsonify({"result": "fick dich!"})

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5000)
    

    #get userinformation

    #createuser

    #customcommand