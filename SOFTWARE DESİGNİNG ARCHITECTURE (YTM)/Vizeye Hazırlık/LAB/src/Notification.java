public class Notification implements ISender{

    @Override
    public void send(User user, String message) {
        System.out.println("Bildirim gitti");
    }
    
}
