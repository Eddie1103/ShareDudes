#!/usr/bin/python
import hashlib

def hashPassword(password):
    return hashlib.sha256(password.encode('utf-8')).hexdigest()

#validate array of values