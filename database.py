#!/usr/bin/python
import psycopg2
import hashlib
from config import config

class Database:

    def __init__(self):
        db = Database
        self.dbase = db.connect()

    def create():
        db = Database
        db.dbase = db.connect() 
        return db

    def connect():
        """ Connect to the PostgreSQL database server """
        conn = None
        try:
            # read connection parameters
            params = config()

            # connect to the PostgreSQL server
            print('Connecting to the PostgreSQL database...')
            conn = psycopg2.connect(**params)
            
            # create a cursor
            cur = conn.cursor()
            
        # execute a statement
            print('PostgreSQL database verbunden:')
            cur.execute('SELECT version()')
            db_version = cur.fetchone()
            print(db_version)

            return conn

        except (Exception, psycopg2.DatabaseError) as error:
            print(error)
            return None
        
        
    def select(self, condition):
        sqlcommand = f'select * from users '
        if condition != None:
            sqlcommand+=condition
        sqlcommand+=';'

        db=self.dbase
        cur=db.cursor()
        cur.execute(sqlcommand)
        return cur.fetchall()

    def createUser(self, values):
        password = values[1]
        hashed_password = hashlib.sha256(password.encode('utf-8')).hexdigest()
        
        print('hashedpassord:', hashed_password)

        cur=self.dbase.cursor()
        cur.execute('insert into users(username, password, email_address, birthdate, is_admin) VALUES(%s, %s,%s,%s,%s)', 
                             (values[0], hashed_password,values[2],values[3],values[4]))
        
        #id raussuchen
        cur.execute('select user_id from users order by user_id DESC LIMIT 1')
        fetch = cur.fetchone()

        userid = fetch[0]
        print(fetch)
        print(userid)
        #addresse erstellen
        #stringexec = 'insert into address(street, housenumber, city, state, user_id) values(%s, %s, %s, %s, %s)'%values[5] %values[6]% values[7]% values[8]% values[9]% userid 

        #print(stringexec)
        cur.execute('insert into address(street, housenumber, postalcode, city, state, is_main, user_id) values(%s, %s, %s, %s, %s, %s, %s)',
                   (values[5], values[6], values[7], values[8], values[9], True, userid))


        self.dbase.commit()
        return 'success'
        

    def customCommand(self, value):
        sqlcommand = f'{value};'

        db=self.dbase
        cur=db.cursor()
        cur.execute(sqlcommand)
        return cur.fetchone()


