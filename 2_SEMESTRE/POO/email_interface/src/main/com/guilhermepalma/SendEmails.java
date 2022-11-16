package com.guilhermepalma;

import java.util.*;

/* Desenvolva uma interface EmailInterface para disponibilizar os métodos getNome e getEmail */
interface EmailInterface {
    List<String> getNames();

    Set<String> getEmails();
}

/* Desenvolva uma classe Cliente com no mínimo os atributos nome e email, e os respectivos métodos getters e setters */
class Client {
    private String name;
    private String email;

    public Client(String name, String email) {
        this.name = name;
        this.email = email;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }
}

/* Desenvolva uma classe Fornecedores com no mínimo os atributos nome e email, e os respectivos métodos getters e setters */
class Provider {
    private String name;
    private String email;

    public Provider(String name, String email) {
        this.name = name;
        this.email = email;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }
}

/*
Desenvolva uma classe Email para consumir os métodos da interface,

A classe email deve ter no mínimo os atributos :  titulo e mensagem, além do array para nome e email
 de clientes e fornecedores que receberão o email
*/
class Email implements EmailInterface {

    private String title;
    private String message;

    // Map with Email (Key) and Names (values) 
    private Map<String, String> emailsToSend;

    public Email() {
    }

    public Email(String title, String message) {
        this.title = title;
        this.message = message;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getMessage() {
        return message;
    }

    public void setMessage(String message) {
        this.message = message;
    }

    public Map<String, String> getEmailsToSend() {
        return emailsToSend;
    }

    public void setEmailsToSend(Map<String, String> emailsToSend) {
        this.emailsToSend = emailsToSend;
    }

    public void addClient(Client c) {
        if (c == null) {
            throw new IllegalArgumentException("The Client can't be null");
        }

        if (emailsToSend == null) {
            this.setEmailsToSend(new HashMap<>());
        }

        emailsToSend.put(c.getEmail(), c.getName());
    }

    public void addProvider(Provider c) {
        if (c == null) {
            throw new IllegalArgumentException("The Provider can't be null");
        }

        if (emailsToSend == null) {
            emailsToSend = new HashMap<>();
        }

        emailsToSend.put(c.getEmail(), c.getName());
    }

    public List<String> generateListEmails() {
        if (this.getEmailsToSend() == null || this.getEmailsToSend().isEmpty()) {
            throw new IllegalArgumentException("The List with Emails and Names can't be null or empty");
        } else if (this.getTitle() == null || this.getTitle().isBlank()) {
            throw new IllegalArgumentException("The Title of Emails can't be null or empty");
        } else if (this.getMessage() == null || this.getMessage().isBlank()) {
            throw new IllegalArgumentException("The Message of Emails can't be null or empty");
        }

        List<String> emails = new ArrayList<>();
        this.getEmailsToSend().forEach((email, name) -> {
            emails.add(generateUniqueEmail(email, name));
        });


        return emails;
    }

    public String generateUniqueEmail(String destinatary, String name) {
        if (destinatary == null || destinatary.isBlank()) {
            throw new IllegalArgumentException("The Emails can't be null or empty");
        } else if (name == null || name.isBlank()) {
            throw new IllegalArgumentException("The Emails can't be null or empty");
        } else if (this.getTitle() == null || this.getTitle().isBlank()) {
            throw new IllegalArgumentException("The Title of Emails can't be null or empty");
        } else if (this.getMessage() == null || this.getMessage().isBlank()) {
            throw new IllegalArgumentException("The Message of Emails can't be null or empty");
        }

        StringBuilder emailBuilder = new StringBuilder();
        addLine(emailBuilder, String.format("Nome: %s", name));
        addLine(emailBuilder, String.format("Email: %s", destinatary));

        addLine(emailBuilder, String.format("Titulo: %s", this.getTitle()));
        addLine(emailBuilder, String.format("Mensagem: %s", this.getMessage()));
        breakLine(emailBuilder);

        return emailBuilder.toString();
    }

    private void addLine(StringBuilder builder, String message) {
        if (builder == null) {
            builder = new StringBuilder();
        }

        if (!builder.isEmpty()) {
            builder.append("\n");
        }

        if (message != null && !message.isBlank() && !message.isEmpty()) {
            builder.append(message);
        }
    }

    private void breakLine(StringBuilder builder) {
        if (builder == null) {
            builder = new StringBuilder();
        }

        builder.append("\n");
    }

    @Override
    public List<String> getNames() {
        return (this.getEmailsToSend() == null || this.getEmailsToSend().size() == 0) ? new ArrayList<>() : new ArrayList<>(this.getEmailsToSend().values());
    }

    @Override
    public Set<String> getEmails() {
        return (this.getEmailsToSend() == null || this.getEmailsToSend().size() == 0) ? new HashSet<>() : this.getEmailsToSend().keySet();
    }
}


/*
Desenvolva o programa enviarEmail.php, que deverá fazer uso das classes desenvolvidas para enviar emails,
ex, email institucional para clientes e fornecedores, informando a mudança de endereço.

A saída deste programa será uma listagem  dos emails :

Nome : John
Email : John@gmail.com
Titulo : Mudança de endereço
Mensagem : A partir do dia xx/xx/xxxx estaremos atendendo no endereço yyyyyyyyyyyyyyy


Nome : Ann
Email : Ann@gmail.com
Titulo : Mudança de endereço
Mensagem : A partir do dia xx/xx/xxxx estaremos atendendo no endereço yyyyyyyyyyyyyyy
*/
public class SendEmails {

    // Dados Mocados/Simulados
    static Client c1 = new Client("Gabriel", "gabriel@email.com");
    static Client c2 = new Client("Juliana Luis", "julianaluis@email.com");
    static Client c3 = new Client("Loan", "loan@email.com");

    static Provider p1 = new Provider("Revendedora Arais", "vendas@arais.com");
    static Provider p2 = new Provider("DIST LTDa", "dist@distltda.com");
    static Provider p3 = new Provider("Importações LUI", "vendas@lui.com");

    public static void main(String[] args) {
        notifyChangeOfAddress();
        notifyChangeOfTime();
        notifyPayment();
    }

    private static void notifyChangeOfAddress() {
        Email changeLocalEmail = new Email("Mudança de Endereço - Nova Sede", "A partir do dia 01/01/2023 estaremos atendendo no endereço Av. Paulista n° 131");

        changeLocalEmail.addClient(c1);
        changeLocalEmail.addClient(c2);
        changeLocalEmail.addClient(c3);

        changeLocalEmail.addProvider(p1);
        changeLocalEmail.addProvider(p2);
        changeLocalEmail.addProvider(p3);

        List<String> listOfEmails = changeLocalEmail.generateListEmails();
        listOfEmails.forEach(System.out::println);
    }

    private static void notifyChangeOfTime() {
        Email changeTime = new Email("Mudança do Horario de Atendimento", "A partir do dia 01/01/2023, teremos uma alteração no Horario de Atendimento. Segunda à Sexta-Feira: 10:00hr às 19:00hr, Sabado: 12:00hr às 19:00hr");

        changeTime.addClient(c1);
        changeTime.addClient(c2);
        changeTime.addClient(c3);

        List<String> listOfEmails = changeTime.generateListEmails();
        listOfEmails.forEach(System.out::println);
    }

    private static void notifyPayment() {
        Email payment = new Email("Cobrança 12/2022", "Atente-se à data de vencimento e evite Multas. Data do Proximo Pagamento: 10/12/2022");

        payment.addProvider(p1);
        payment.addProvider(p2);
        payment.addProvider(p3);

        List<String> listOfEmails = payment.generateListEmails();
        listOfEmails.forEach(System.out::println);
    }

}