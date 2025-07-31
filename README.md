# 🧠 TCP Chat Application in C#

A simple console-based TCP chat application using C# and .NET. It demonstrates how to build a client-server architecture using TCP sockets with multithreading for real-time communication.

---

## 📁 Project Structure

<pre> ``` tcp-chat-app-csharp/ ├── TcpChatApp.sln ├── ChatServer/ │ ├── ChatServer.cs │ └── ChatServer.csproj └── ChatClient/ ├── ChatClient.cs └── ChatClient.csproj ``` </pre>

---

## 🚀 How to Run

### 🖥️ With .NET CLI (TERMINAL)

1. **Start the Server**  
   Open a terminal and go to the `ChatServer` folder:
   ```bash
   dotnet run

You will see: `Server started. Waiting for connection...`

2. **Start the Client**  
   Open another terminal and go to the `ChatClient` folder:
   ```bash
   dotnet run
 	
Now both sides can send and receive messages in real-time!

---

### 💻 With Visual Studio

1. Open `TcpChatApp.sln`
2. Right-click `ChatServer` → Set as Startup Project → Run
3. Then right-click `ChatClient` → Set as Startup Project → Run
4. Both terminals will appear and allow two-way messaging

---

## 🔧 Technologies Used

- C# (.NET 6+)
- TCP/IP Sockets (`System.Net.Sockets`)
- Multithreading (`System.Threading`)
- Console I/O

---

## 🛠 Features

- Two-way communication (Client <--> Server)
- Real-time message exchange via TCP sockets
- Uses multithreading for simultaneous send/receive

---

## 🔐 Future Improvements

- Support multiple clients (multi-threaded server)
- Add message encryption (e.g., SSL or AES)
- Save chat history in a database
- Add GUI using WinForms or WPF

---

## 🧑‍💻 Author

**Hariharan**  
🔗 [Portfolio](https://harixh-dev.github.io/portfolio)  
🔗 [GitHub](https://github.com/harixh-dev)

---

## 📄 License

This project is open-source and available under the [MIT License](LICENSE).

