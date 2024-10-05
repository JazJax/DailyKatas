/*
 * This source file was generated by the Gradle 'init' task
 */
package org.example

import org.junit.jupiter.api.Test
import org.junit.jupiter.api.Assertions.assertNotNull
import org.junit.jupiter.api.Assertions.assertEquals
import org.junit.jupiter.api.Assertions.assertArrayEquals
import java.io.File
import java.io.BufferedReader

val root: String = File("").absolutePath
val resourcesPath: String = root + "/src/test/resources/"

class AppShould {
    val sut = App()
    @Test
    fun printAGrid() {
        assertNotNull(sut.printGrid(), "app should have a greeting")
    }
    @Test
    fun initialiseGridCorrectly() {
        val bufferedReader: BufferedReader = File(resourcesPath+"25x25_blank.txt").bufferedReader()
        val expected: String = bufferedReader.readText()
        val actual: String = sut.printGrid()
        assertEquals(expected, actual)
    }
    @Test
    fun initialiseSnakeCorrectly() {
        val expectedLength: Int = 1
        val expectedPlacement: Array<Pair<Int,Int>> = arrayOf<Pair<Int,Int>>(Pair(12,12))
        assertEquals(expectedLength, sut.snake.length)
        assertArrayEquals(expectedPlacement, sut.snake.snakeSquares)
    }
}

class GridShould {
    @Test
    fun be25x25() {
        val expected = 25
        val sut = Grid(expected)
        assertEquals(expected, sut.size)
        assertEquals(sut.values.size, expected)
        sut.values.forEach { assertEquals(expected, it.size)}
    }
    @Test
    fun containOnlyBlankSquares() {
        val sut = Grid(4)
        sut.values.forEach {
            it.forEach { assertEquals('⯀', it) }
        }
    }
    @Test
    fun acceptASnakePosition() {
        val sut = Grid(4)
        val snake = Snake(arrayOf<Pair<Int,Int>>(Pair(1,1)))
        sut.updateSnakePosition(snake)
    }
    @Test
    fun printSnakeOnTheGrid() {
        val sut = Grid(3)
        val coOrd = Pair(0,2)
        println(coOrd.first)
        println(coOrd.second)
        val snake = Snake(arrayOf<Pair<Int,Int>>(coOrd))
        val expectedInitial: String = """
            >| ⯀ ⯀ ⯀ |
            >| ⯀ ⯀ ⯀ |
            >| ⯀ ⯀ ⯀ |""".trimMargin(">")
        val expectedResult: String = """
            >| ⯀ ⯀ ⯀ |
            >| ⯀ ⯀ X|
            >| ⯀ ⯀ ⯀ |""".trimMargin(">")
        //Confirm blank beforehand:
        assertEquals(expectedInitial, sut.printGrid())
        sut.updateSnakePosition(snake)
        assertEquals(expectedResult, sut.printGrid())
    }
}

class SnakeShould {
    @Test
    fun haveLength() {
        val coOrds: Array<Pair<Int,Int>> = arrayOf(Pair(1,1))
        val sut = Snake(coOrds)
        assertNotNull(sut.length)
    }
}

// class InputParserShould {
//     val sut = InputParser()
//     @Test
//     fun acceptDirections() {
        
//     }
// }
