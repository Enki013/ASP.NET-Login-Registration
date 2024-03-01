# **Student Grade Average Application**

This application allows students to log in, register, and calculate their grade averages. It is developed using ASP.NET Web Forms.

## **Features**

- **Login Page (Giris.aspx):** Allows users to log in with a username and password. It handles incorrect login attempts and session timeouts.
- **Registration Page (Kayit.aspx):** Enables new users to register by providing a username and password. Usernames must be unique.
- **Grade Average Page (NotOrtalama.aspx):** Users can input three different exam grades. The application calculates the average grade based on the inputs and displays it to the user.

## **How to Use**

- **Log In:**
  - Navigate to the login page (**Giris.aspx**).
  - Enter your username and password if you have a registered account.
  - Click on the "Giriş Yap" (Login) button.
- **Register:**
  - Click on the "Kayıt Ol" (Register) link on the login page.
  - Provide a username and password.
  - Click on the "Kayıt Ol" (Register) button.
- **Calculate Grade Average:**
  - After logging in, go to the "Not Ortalama" (Grade Average) page (**NotOrtalama.aspx**).
  - Enter three different exam grades.
  - Click on the "Ortalama Hesapla" (Calculate Average) button.
- **Log Out:**
  - End your session by clicking on the "Çıkış Yap" (Log Out) button on any page.

## **Development**

- The application is developed using ASP.NET Web Forms.
- It is written in the C# programming language.
- User information is stored in a text file (**kullanicilar.txt**).
- Usernames and passwords are stored in a simple text file. A more robust authentication mechanism is recommended for security purposes.

## **Contributions**

- This project is open-source and contributions are welcome.
- If you find any bugs or have suggestions, please open an issue or submit a pull request.

This README file outlines the general features of the project and how to use it. It's designed to help users understand and utilize the project effectively.
