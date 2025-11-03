from datetime import datetime
from aiosmtpd.controller import Controller
from aiosmtpd.handlers import Message

SERVER_HOST = "localhost"
SERVER_PORT = 8025
FILTER_LIST = []

class MailCaptureHandler(Message):
    
    def handle_message(self, msg):
        if(len(FILTER_LIST) == 0 or msg["To"] in FILTER_LIST):
            print("------------ MESSAGE ARRIVED -----------\n")
            print("At     :", datetime.now().strftime("%Y-%m-%d %H:%M:%S"))
            print("From   :", msg["From"])
            print("To     :", msg["To"])
            print("Subject:", msg["Subject"])
            print()
            print(msg.get_payload(decode=True).decode())
            print("------------ END OF MESSAGE ------------\n")
        return "250 OK"
        

print("\033[H\033[J", end="")
server = Controller(MailCaptureHandler(), hostname=SERVER_HOST, port=SERVER_PORT)
server.start()
print("Server started on", SERVER_HOST + ":" + str(SERVER_PORT))
input("Press Enter key to stop...\n\n")

#pip install aiosmtpd --break-system-packages


