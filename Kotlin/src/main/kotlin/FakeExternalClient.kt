import com.github.javafaker.Faker

class FakeExternalClient {
    private val faker = Faker()

    fun getMessage(messageId: Int): String {
        return "MessageId: $messageId -> $faker.lorem().sentence()"
    }
}