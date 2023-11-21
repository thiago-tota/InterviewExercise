import com.nhaarman.mockitokotlin2.*
import org.junit.jupiter.api.Test

class ApplicationStartTest {

    private val mockedConsole: Console = mock<Console>()
    private val applicationStart = ApplicationStart(mockedConsole)

    @Test
    fun `test that application quits the program only when Q is typed`() {
        whenever(mockedConsole.read("Type your message:"))
            .thenReturn("q")
            .thenReturn("q")
            .thenReturn("Q")

        applicationStart.execute()

        verify(mockedConsole, times(3)).read("Type your message:")
    }
}