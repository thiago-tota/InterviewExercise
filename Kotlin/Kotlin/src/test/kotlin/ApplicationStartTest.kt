import com.nhaarman.mockitokotlin2.mock
import com.nhaarman.mockitokotlin2.times
import com.nhaarman.mockitokotlin2.verify
import com.nhaarman.mockitokotlin2.whenever
import org.junit.jupiter.params.ParameterizedTest
import org.junit.jupiter.params.provider.ValueSource

class ApplicationStartTest {

    private val mockedConsole: Console = mock<Console>()
    private val applicationStart = ApplicationStart(mockedConsole)

    @ParameterizedTest
    @ValueSource(strings = ["Q", "q"])
    fun `test that application quits the program only when Q is typed (ignoring case)`(inputToExistProgram: String) {
        whenever(mockedConsole.read("Type your message:"))
            .thenReturn("quit")
            .thenReturn("exit")
            .thenReturn(inputToExistProgram)

        applicationStart.execute()

        verify(mockedConsole, times(3)).read("Type your message:")
    }
}