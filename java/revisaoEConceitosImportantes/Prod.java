public class Prod {
    private String nome;
    private double preco;
    private int quantidade;

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

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public double getPreco() {
        return preco;
    }

    public void setPreco(double preco) {
        this.preco = preco;
    }

    public int getQuantidade() {
        return quantidade;
    }

    public void setQuantidade(int quantidade) {
        this.quantidade = quantidade;
    }
}
