from flask import Flask, render_template

app = Flask(__name__)

@app.route("/")
def index():
    pokemons = [
        {
            'numero': '001',
            'nome': 'Bulbasaur'

        },
        {
            'numero': '002',
            'nome': 'Ivysaur'

        },
        {
            'numero': '003',
            'nome': 'Venusaur'

        },
        {
            'numero': '004',
            'nome': 'Charmander'

        },
        {
            'numero': '005',
            'nome': 'Charmeleon'

        },
        {
            'numero': '006',
            'nome': 'Charizard'

        },
        {
            'numero': '007',
            'nome': 'Squirtle'

        },
        {
            'numero': '008',
            'nome': 'Wartotle'

        },
        {
            'numero': '009',
            'nome': 'Blastoise'

        },
    ]
    caminhoBase = "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/"

    return render_template("index.html",pokemons=pokemons, caminhoBase=caminhoBase)

if (__name__ == ("__main__")):
    app.run(debug=True)