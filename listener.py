#!/usr/bin/python
import psycopg2
from database import Database
from flask import Flask, request, jsonify

DATABASE = Database.create()

app = Flask(__name__)

@app.route('/getuserinformations', methods=['POST'])
def getuserinformations():
    data = request.json
    condition = data.get('values')

    print(condition)
    #condition(where id=2 | where username='Henry')
    return jsonify({"result": DATABASE.select(DATABASE, condition)})


'''
@app.route('/', methods=['POST'])
def request_database():

    methode = request.args.get('methode')
    
    if methode=='getuserinformations':
        condition = request.args.get('values')
        #condition(where id=2 | where username='Henry')
        return jsonify({"result": DATABASE.select(condition)})
    elif methode =='createuser':
        values = request.args.get('values')
        #values(name, password, birthdate)
        return jsonify({"result": DATABASE.createUser(values)})
    elif methode=='customCommand':
        return jsonify({"result": DATABASE.customCommand(values)})
    else:

        return jsonify({"answer" : request})
        return jsonify({"error": "function not found"}), 403
'''

@app.route('/', methods=['OPTION'])
def request_database():
    return jsonify({"answer" : request})


if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5000)
    