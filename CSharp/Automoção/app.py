import pyautogui as auto

auto.PAUSE = 0.7

def abrirApp(nomeApp):
    auto.press("win")
    auto.write(f"{nomeApp}")
    auto.press("enter")

    opera = ["opera", "opera gx", "opera GX", "opera Gx", "Opera", "Opera gx", "opera GX"]
    if nomeApp in opera:
        # abrir Board
        auto.moveTo(856, 81)
        auto.click()

        # abrir ACMS
        auto.moveTo(1004, 80)
        auto.click(button="right")
        auto.moveTo(1067, 132)
        auto.click()

        # abrir o YouTube
        auto.moveTo(203, 83)
        auto.click(button="right")
        auto.moveTo(308, 133)
        auto.click()

def abrir_multiplos_apps(apps):
    apps_lista = apps.split(',')  # Supondo que os aplicativos sejam separados por vírgula
    for app in apps_lista:
        print(f"Abrindo o aplicativo: {app.strip()}")
        abrirApp(app.strip())  # Remove espaços em branco e chama abrirApp
        auto.hotkey('win', 'down')  # Minimiza todas as janelas
