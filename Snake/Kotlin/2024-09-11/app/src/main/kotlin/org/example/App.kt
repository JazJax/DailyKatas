/*
 * This source file was generated by the Gradle 'init' task
 */
package org.example

class App {
    lateinit private var grid: Grid
    private var gridSize: Int = 25

    init {
        grid = Grid(gridSize)
    }

    val greeting: String
        get() {
            return "Hello World!"
        }
    
    fun printGrid(): String {
        val builder = StringBuilder()
        grid.values.forEach() {
            builder.appendLine(it.contentToString())
        }
        val output = builder.toString().trim()
        return output
    }
}

data class Grid(val size: Int) {
    val emptySpace: Char = '⯀'
    lateinit var values: Array<Array<Char>>

    init {
        val row: Array<Char> = Array(size){emptySpace}
        values = Array(size){ row }
    }
}

data class Snake(val coords: Array<Pair<Number,Number>>) {

}

fun main() {
    val testGrid = Grid(25)
    testGrid.values.forEach() {
        println(it.contentToString())
    }
}
