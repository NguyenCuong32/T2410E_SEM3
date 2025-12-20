from flask import Flask, jsonify, request
from data_util import DataUtil
# khởi tạo ứng dụng Flask
app = Flask(__name__)


# Route để lấy tất cả sản phẩm
@app.route('api/v1/products', methods=['GET'])
def get_all_products():
    products = DataUtil.get_products()
    return jsonify(products)


