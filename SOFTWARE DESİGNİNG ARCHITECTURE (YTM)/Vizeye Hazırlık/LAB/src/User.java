interface User {
    void showProduct(Product product);

}
interface Login {
    void logIn();
}
interface Sellable{
    void addProduct(Product product);
}
class Customer implements User, Login{
    private String name;
    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }
    public Customer(String name){setName(name);}

    @Override
    public void logIn() {
        System.out.println("Signed");
    }

    @Override
    public void showProduct(Product product) {
        System.out.println(getName()+" | "+product.getName()+"  :  "+product.getPrice());

    }}
class Seller implements User,Sellable, Login{
    private String name;
    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }
    public Seller(String name){setName(name);}
    @Override
    public void addProduct(Product product) {
        Db.getDB().AddProduct(product);
        System.out.println(getName()+" | "+product.getName()+"  :  "+product.getPrice());

        
    }

    @Override
    public void logIn() {
        System.out.println("Signed");
        
    }

    @Override
    public void showProduct(Product product) {
        System.out.println(getName()+" | "+product.getName()+"  :  "+product.getPrice());
        
    }
}

 