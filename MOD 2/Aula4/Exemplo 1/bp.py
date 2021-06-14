from flask import Blueprint
from flask import render_template

bp = Blueprint('bp',__name__)

@bp.route("/")
def home():
    return "<h1>a</h1>"

@bp.route("/login/<nome>")
def login(nome=None):
    return "<center><h1>Olá "+nome+", bem vindo.<br>Faça seu login!</h1></center>"

@bp.route("/auladeontem")
def carregar():
    return render_template("index.html")

@bp.route("/teste")
def teste():
    return "<center><h1>a</center></h1>"