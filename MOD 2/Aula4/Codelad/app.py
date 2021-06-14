from logging import debug
from flask import Flask, render_template

app = Flask(__name__)

@app.route("/")
def index():
    nome = "Albert Einstein"
    idade = 42
    situacao = 'normal'
    if situacao == 'doido':
        doidao = True
    else:
        doidao = False
    imgdoidao = "/static/foto1.jpg"
    imgnormal = "/static/foto2.jpg"
    return render_template('index.html',nome=nome,idade=idade,situacao=situacao,imgdoidao=imgdoidao,imgnormal=imgnormal,doidao=doidao)

if (__name__ == "__main__"):
    app.run(debug=True)