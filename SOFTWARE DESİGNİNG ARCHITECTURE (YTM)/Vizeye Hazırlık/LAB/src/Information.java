public class Information {
    private Sms sms;
    private Mail mail;
    private Notification notification;
    public Information(){
        sms = new Sms();
        mail = new Mail();
        notification = new Notification();
    }
    public void GiveInfo(User user, String message){
        sms.send(user, message);
        
        mail.send(user, message);

        notification.send(user, message);
    }
}
interface ISender{
    void send(User user, String message);
}