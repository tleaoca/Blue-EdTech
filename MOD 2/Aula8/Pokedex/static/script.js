const cardPokemons = document.querySelectorAll(".card_pokemon");
const pokemonSelecionado = document.querySelector("#pokemon_selecionado");

function selecionaPokemon(){
    const nomePokemon = this.getAttribute("data-nome");

    if(!this.classList.contains("selecionado")){
        this.classList.add("selecionado");
        pokemonSelecionado.innerHTML = `O último pokemon selecionado foi <b>${nomePokemon}</b>`;        
    }
    else{
        this.classList.remove("selecionado");
        const pokemonsSelecionados = document.querySelectorAll(".selecionado")
        if (pokemonsSelecionados.length >= 1){
            pokemonSelecionado.innerHTML = `Você desselecionou o pokemon ${nomePokemon}, resta(m) ${pokemonsSelecionados.length} selecionado(s)`            
        }
        else{
            pokemonSelecionado.innerHTML = document.innerHTML = "Selecione um pokemon"
        }
    }
}

for(const cardPokemon of cardPokemons){
    cardPokemon.addEventListener("click",selecionaPokemon)
}