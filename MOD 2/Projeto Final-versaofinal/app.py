# Equipe:
# Paulo Gabriel Lemos
# Thiago Leão Carneiro
# Vivianne Sophie Sousa Guimarães

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

    def __init__(self, nome, ingredientes, preco, imagem_url):
        self.nome = nome
        self.ingredientes = ingredientes
        self.preco = preco
        self.imagem_url = imagem_url 

    @staticmethod
    def read_all():
        return Hamb.query.order_by(Hamb.id.asc()).all()

    @staticmethod
    def read_single(id_registro):
        return Hamb.query.get(id_registro)

    @staticmethod
    def conta():
        return Hamb.query.count()
    
    def save(self):
        db.session.add(self)
        db.session.commit()

    def update(self, novo_nome, novo_ingredientes, novo_preco, novo_imagem_url):
        self.nome = novo_nome
        self.ingredientes = novo_ingredientes
        self.preco = novo_preco
        self.imagem_url = novo_imagem_url

        self.save()

    def delete(self):
        db.session.delete(self)
        db.session.commit()

@app.route("/")
def index():
    return render_template("index.html")

@app.route("/read")
def read_all():
    registros = Hamb.read_all()
    return render_template("read_all.html", registros=registros)

@app.route("/read/<id_registro>")
def read_id(id_registro):
    registro = Hamb.read_single(id_registro)
    return render_template("read_single.html", registro=registro)

@app.route("/create", methods=('GET', 'POST'))
def create():
    novo_id = None
    if request.method == 'POST':
        form = request.form
        registro = Hamb(form['nome'], form['ingredientes'], form['preco'], form['imagem_url'])
        registro.save()
        novo_id = registro.id    
    return render_template("create.html", novo_id=novo_id)

@app.route("/update/<id_registro>", methods=('GET', 'POST'))
def update(id_registro):
    sucesso = False
    registro = Hamb.read_single(id_registro)
    if request.method == 'POST':
        form = request.form
        registro.update(form['nome'], form['ingredientes'], form['preco'], form['imagem_url'])
        sucesso = True    
    return render_template('update.html', registro=registro, sucesso=sucesso)

@app.route("/delete/<id_registro>")
def delete(id_registro):
    registro = Hamb.read_single(id_registro)
    return render_template("delete.html", registro=registro)

@app.route("/delete/<id_registro>/confirmed")
def delete_confirmed(id_registro):
    sucesso = False
    registro = Hamb.read_single(id_registro)
    if registro:
        registro.delete()
        sucesso = True
    return render_template("delete.html", registro=registro, sucesso=sucesso)

if (__name__ == "__main__"):
    app.run(debug=True)

   
