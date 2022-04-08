public class Sms implements ISender{
    public void SmsGonder(User user, String message){
        System.out.println("Kullanıcını mesajı : "+ message);
    }
    @Override
    public void send(User user, String message) {
        System.out.println("Kullanıcını sms mesajı : "+ message);
        
    }
}
