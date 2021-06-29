from flask import Flask, render_template
from flask_sqlalchemy import SQLAlchemy

app = Flask(__name__)

# Configurações de acesso ao banco de dados:
user = 'pewannaq'
password = 'f5_In1_pWLah1_HekB0qvMlkrtF078kZ'
host = 'tuffi.db.elephantsql.com'
database = 'pewannaq'

app.config['SQLALCHEMY_DATABASE_URI'] = f'postgresql://{user}:{password}@{host}/{database}'
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
app.secret_key = "chave secreta"

db = SQLAlchemy(app)

# Modelar a Classe Filmes -> tabela filmes na da database
class Filmes(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    nome = db.Column(db.String(255), nullable=False)
    imagem_url = db.Column(db.String(255), nullable=False)

    def __init__(self, nome, imagem_url):
        self.nome = nome
        self.imagem_url = imagem_url 

    @staticmethod
    def read_all():
        # SELECT DO POSTGRESQL
        return Filmes.query.order_by(Filmes.id.asc()).all()


@app.route("/")
def index():
    return render_template("index.html")

@app.route("/read")
def read_all():
    # Chamada do método read_all da classe Filmes(definido acima) que representa a tabela filmes no banco de dados
    registros = Filmes.read_all()
    return render_template("read_all.html", registros=registros)

@app.route("/read/<id_registro>")
def read_id(id_registro):
    return "Em construção - Visualizar o registro do ID"+id_registro

@app.route("/create")
def create():
    return "Em construção - Ainda será feito o Create!"


if (__name__ == "__main__"):
    app.run(debug=True)