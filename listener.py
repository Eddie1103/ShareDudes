from flask import Flask, request, jsonify

app = Flask(__name__)

@app.route('/request_database', methods=['GET'])
def extract_text():
    
    sqlcommand = request.args.get('methode')
    


    return jsonify({"error": "coming son"}), 403

    
if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5000)
