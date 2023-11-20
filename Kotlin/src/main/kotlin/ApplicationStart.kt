import java.util.*

object ApplicationStart {
    fun execute() {
        val scanner = Scanner(System.`in`)
        while (true) {
            try {
                println(getMenuText())
                println("Type your message:")
                val inputMsg = scanner.nextLine()
                if (inputMsg == "Q") {
                    break
                }
                postMessage(inputMsg)
            } catch (e: Exception) {
                println(e.message)
            }
        }
    }

    private fun getMenuText(): String {
        val sb = StringBuilder()

        sb.appendLine("")
        sb.appendLine("Welcome!")
        sb.appendLine("Q to exit the application;")

        return sb.toString()
    }

    private fun postMessage(message: String){
        println("My first post: $message")
    }
}