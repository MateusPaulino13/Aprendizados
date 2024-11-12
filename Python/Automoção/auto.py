import app as a
from tkinter import *

# Função que inicia os aplicativos
def iniciar_apps():
    # Captura o texto do Entry
    apps = appSelected.get()  # Obtém o texto do campo de entrada
    a.abrir_multiplos_apps(apps)  # Chama a função passando o texto como argumento

# Cria a janela principal
window = Tk()
window.geometry("450x150")
window.title("Inicializador de aplicativos")

# Label para instruções
LabelAppSelect = Label(window, text="Digite quais aplicativo(s) você deseja abrir:")
LabelAppSelect.grid(row=0, column=1, pady=15)

# Campo de entrada (Entry)
appSelected = Entry(window, width=30)
appSelected.grid(row=0, column=2)


# Botão que chama a função para iniciar aplicativos
btn = Button(window, text="Iniciar Aplicativos", command=iniciar_apps, width=20, height=2)   
btn.grid(row=1, column=2)

# Inicia o loop da interface
window.mainloop()
