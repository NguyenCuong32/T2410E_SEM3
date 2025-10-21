import json
from pymongo import MongoClient

class DataUtil:
    @staticmethod
    def get_products():
        print("Fetching all products from the database...")
        client = MongoClient('mongodb://localhost:27017/')
        db = client['ldm_demo']
        collection = db['products']
        products = collection.find()
        products_list = []
        for product in products:
            product['_id'] = str(product['_id'])  # Convert ObjectId to string for JSON serialization
            products_list.append(product)
        return products_list