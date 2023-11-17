#!/usr/bin/python
import psycopg2
from config import config

class Database:
    
    DATABASE = psycopg2.connect

    def create():
        db = Database
        db.DATABASE =db.connect() 
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
        sqlcommand = f'select * from users'
        if condition != None:
            sqlcommand+=condition + ';'

        db=self.DATABASE
        cur=db.cursor()
        cur.execute(sqlcommand)
        return cur.fetchall()

    def createUser(self, values):
        sqlcommand = f'insert into users(name, alter, passwort) VALUES({values});'

        db=self.DATABASE
        cur=db.cursor()
        cur.execute(sqlcommand)
        return cur.fetchone()
        