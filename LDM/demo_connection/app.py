from pymongo import MongoClient



# Function to retrieve all products from the collection
def get_all_products():
    connect_string = "mongodb://127.0.0.1:27017/"
    client = MongoClient(connect_string)
    db = client["ldm_demo"]
    collection = db["products"]
    if collection is not None:
        documents = collection.find()
        return list(documents)
    else:
        return []

def get_all_orders():
    connect_string = "mongodb://127.0.0.1:27017/"
    client = MongoClient(connect_string)
    db = client["ldm_demo"]
    collection = db["orders"]
    if collection is not None:
        documents = collection.find()
        return list(documents)
    else:
        return []

if __name__ == "__main__":
    while (True):
        key = input("Press a number to continue or 'q' to quit: ")
        if key.lower() == "1":
            products = get_all_products()
            for product in products:
                    print(product)
        elif key.lower() == "2":
            orders = get_all_orders()
            for order in orders:
                print(order)
        elif key.lower() == "q":
            break

  
