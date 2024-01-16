#!/usr/bin/python
import psycopg2
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
            sqlcommand+=condition + ';'

        db=self.dbase
        cur=db.cursor()
        cur.execute(sqlcommand)
        return cur.fetchall()

    def createUser(self, values):
        hashpassword = hash(values[1])
        print('hashedpassord:', hashpassword)
        sqlcommand = f"insert into users(username, password, email_address, birthdate, is_admin) VALUES('{values[0]}','{hashpassword}','{values[2]}','{values[3]}','{values[4]}')"
        print('SQLCommand: ', sqlcommand)
        
        db=self.dbase
        cur=db.cursor()
        cur.execute(sqlcommand)
        return cur.fetchone()
        

    def customCommand(self, value):
        sqlcommand = f'{value};'

        db=self.dbase
        cur=db.cursor()
        cur.execute(sqlcommand)
        return cur.fetchone()


