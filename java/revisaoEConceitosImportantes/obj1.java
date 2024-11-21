public class obj1 {
    public static void main(String[] args) {
       Prod p1 = new Prod("TV", 900.00, 2);
       System.out.println(p1.getTotal());
       p1.setAtualizaPreco(20);
       System.out.println(p1.getTotal());
    }
};
