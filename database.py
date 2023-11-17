#!/usr/bin/python
import psycopg2
from config import config

class Database:
    
    DATABASE = psycopg2._T_conn

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
        
        
    def select(table, condition):
        sqlcommand = f'select * from users'
        if condition != None:
            sqlcommand+=condition + ';'
            #hier execute command, fetch und return
        return None

    def createUser(values):
        sqlcommand = f'insert into users(name, alter, passwort) VALUES({values});'
        #hier execute und bool zurückgeben, ob erfolgreich, oder nicht
        return None
        