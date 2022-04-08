public class App {
    public static void main(String[] args) throws Exception {
      Product pc= new Product("Computer", 1500);
      Product phone= new Product("Phone", 300);
      Customer customer = new Customer("Joe");
      Seller seller = new Seller("Bob");
      customer.logIn();
      seller.logIn();
      seller.addProduct(pc);
      seller.addProduct(phone);
      customer.showProduct(pc);
      Db.getDB().showProduct();

    }
}
