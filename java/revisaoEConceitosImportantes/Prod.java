public class Prod {
    String nome;
    double preco;
    int quantidade;
    public Prod(String nome, double preco, int quantidade) {
        this.nome = nome;
        this.preco = preco;
        this.quantidade = quantidade;
    }
    public double getTotal() {
        return preco * quantidade;
    }
    public void setAtualizaPreco(double porcentagemDesconto) {
        this.preco = preco * (1 + porcentagemDesconto / 100);
    }
}
