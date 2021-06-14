from flask import Flask

app = Flask(__name__)

@app.route("/")
def helloWorld():
    return "<h1>Hello, flask!</h1><br><h2>Hello, flask!</h2>"

@app.route("/rota2/<nome>")
def rota2(nome=None):
    return "<h1>Bem vindo "+nome+" Rota 2</h1>"

if (__name__ == "__main__"):
    app.run(debug=True)