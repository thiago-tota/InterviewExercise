interface Console {
    fun print(string: String)
    fun read(string: String): String
}

class IntelliJTerminal : Console {

    override fun print(string: String) = println(string)

    override fun read(string: String) = print(string).run { readln() }
}