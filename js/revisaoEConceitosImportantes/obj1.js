class Produto {
    constructor(nomeProd, precoProd, qtdProd) {
        this.nomeProd = nomeProd;
        this.precoProd = precoProd;
        this.qtdProd = qtdProd;
    }
    get total() {
        return this.precoProd * this.qtdProd;
    }
    set updatePrice(percent) {
        this.precoProd = this.precoProd * (1 + percent / 100);
    }
    toString() {
        return `Produto: ${this.nomeProd}, Preço: ${this.precoProd}, Quantidade: ${this.qtdProd}`;
    }
}

const prod1 = new Produto('Camiseta', 50, 3);
const prod2 = new Produto('Calça', 100, 2);

//Sem Poo...
// function total (prod) {
//     return prod.precoProd * prod.qtdProd;
// }

// function updatePrice (prod, percent) {
//     prod.price = prod.precoProd * (1 + percent / 100);
// }


//Usando Poo...
console.log(prod1.total);
prod1.updatePrice = 10;
console.log(prod1.total);
