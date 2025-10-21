from flask import Flask, jsonify, request
from data_util import DataUtil
app = Flask(__name__)
@app.route('/api/v1/products', methods=['GET'])
def get_all_products():
    products = DataUtil.get_products()
    return jsonify(products)


if __name__ == "__main__":
    app.run(debug=True)