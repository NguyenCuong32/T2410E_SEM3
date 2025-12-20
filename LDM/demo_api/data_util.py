import json
from pymongo import MongoClient

class DataUtil:
    @staticmethod
    def get_products():
        print("Fetching all products from the database...")