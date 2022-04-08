import java.util.ArrayList;
import java.util.List;

public class Db {
    private List<User> users;
    private List<Product> products;

    private static Db db= new Db();
    public Db(){
        users= new ArrayList<>();
        products= new ArrayList<>();

    }
    public void AddUser(User user){users.add(user);}
    public void AddProduct(Product product){products.add(product);}
    public void ShowUser(){
        /*for(User user : users){
            System.out.println(user.);
        }*/
    }
    public void showProduct(){
        for(Product product : products){
            System.out.println(product.getName());
        }
    }
    public static Db getDB(){
        return db;
    }

}
