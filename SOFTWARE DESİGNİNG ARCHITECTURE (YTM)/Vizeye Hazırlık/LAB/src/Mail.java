public class Mail implements ISender{
    @Override
    public void send(User user, String message) {
        System.out.println("Kullanıcını maili : "+ message);

    }
    public void MailGonder(User user, String message){
    }
}
