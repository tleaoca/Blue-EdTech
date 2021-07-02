from flask import Flask, render_template, request
from flask_sqlalchemy import SQLAlchemy

app = Flask(__name__)

user = 'pewannaq'
password = 'f5_In1_pWLah1_HekB0qvMlkrtF078kZ'
host = 'tuffi.db.elephantsql.com'
database = 'pewannaq'

app.config['SQLALCHEMY_DATABASE_URI'] = f'postgresql://{user}:{password}@{host}/{database}'
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
app.secret_key = "chave secreta"

db = SQLAlchemy(app)

class Hamb(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    nome = db.Column(db.String(255), nullable=False)
    ingredientes = db.Column(db.String(255), nullable=False)
    preco = db.Column(db.Float, nullable=False)
    imagem_url = db.Column(db.String(255), nullable=False)

    def __init__(self, nome, imagem_url, ingredientes, preco):
        self.nome = nome
        self.ingredientes = ingredientes
        self.preco = preco
        self.imagem_url = imagem_url 
   
