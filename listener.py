import psycopg2
from database import Database
from flask import Flask, request, jsonify

DATABASE = psycopg2._T_conn(Database.connect())

app = Flask(__name__)

@app.route('/request_database', methods=['GET'])
def request_database():

    methode = request.args.get('methode')
    columns = request.args.get('parameters')
    values = request.args.get('values')

    if methode=='get':
        return jsonify({"result": select()})
    elif methode =='set':
        return jsonify({"result": insert(columns, values)})
    else:
        return jsonify({"error": "coming soon"}), 403

def select():
    return None

def insert():
    return None

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5000)
    