class ApplicationStart(private val console: Console = IntelliJTerminal()) {

    fun execute() {
        while (true) {
            console.print(getMenuText())

            val inputMsg = getMessageFromUser()
            if (inputMsg == "Q") {
                break
            }

            postMessage(inputMsg)
        }
    }

    private fun getMenuText() =
        StringBuilder().appendLine("").appendLine("Welcome!").appendLine("Q to exit the application;").toString()

    private fun getMessageFromUser() = console.read("Type your message:")

    private fun postMessage(message: String) {
        console.print(message)
    }
}