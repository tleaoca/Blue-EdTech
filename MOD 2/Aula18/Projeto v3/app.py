from flask import Flask, render_template, request
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
    
    @staticmethod
    def read_single(id_registro):
        # SELECT DO POSTGRESQL COM UMA CONDIÇÃO
        return Filmes.query.get(id_registro)
    
    def save(self):
        db.session.add(self)
        db.session.commit()



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
    registro = Filmes.read_single(id_registro)
    return render_template("read_single.html", registro=registro)

@app.route("/create", methods=('GET', 'POST'))
def create():
    novo_id = None # cria uma variável nula para o novo ID atribuído

    if request.method == 'POST': # verifica se está recebendo alguma coisa por POST
        form = request.form # armazena o formulário recebido por POST

        registro = Filmes(form['nome'], form['imagem_url']) # cria um novo registro (objeto) com nome e imagem_url recebidos
        registro.save() # chama a função save da classe (adiciona e commita)

        novo_id = registro.id # atribui a novo_id o ID do novo registro criado

    return render_template("create.html", novo_id=novo_id)

if (__name__ == "__main__"):
    app.run(debug=True)