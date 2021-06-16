from logging import debug
from flask import Flask, render_template, request

app = Flask(__name__)

@app.route("/", methods=('GET', 'POST'))
def index():
    nome = None
    sobrenome = None
    op1 = None
    op2 = None
    cop1 = None
    cop2 = None
    if request.method == 'POST':
        nome = request.form['nome']
        sobrenome = request.form['sobrenome']


        
    return render_template("index.html",nome=nome,sobrenome=sobrenome,op1=op1,op2=op2)


if (__name__ == "__main__"):
    app.run(debug=True)
