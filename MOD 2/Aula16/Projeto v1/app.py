from flask import Flask, render_template

app = Flask(__name__)

@app.route("/")
def index():
    return render_template("index.html")


registros = [
    {
        "id" : 1,
        "nome" : "Velozes e Furiosos",
        "imagem_url" : "https://br.web.img2.acsta.net/medias/nmedia/18/87/23/46/19873389.jpg"         
    },
    {
        "id" : 2,
        "nome" : "Velozes e Furiosos 2", 
        "imagem_url" : "https://upload.wikimedia.org/wikipedia/pt/2/20/2_Fast_2_Furious_2003.jpg" 
    },
]

@app.route("/read")
def read_all():
    return render_template("read_all.html", registros=registros)

@app.route("/read/<id_registro>")
def read_id():
    return "Em construção - Visualizar o registro do ID"+id_registro

@app.route("/create")
def create():
    return "Em construção - Ainda será feito o Create!"


if (__name__ == "__main__"):
    app.run(debug=True)