fun reverse(input: String): String {
    
    /* Simplest solution
        return input.reversed()
    */

    val characters = input.toCharArray()
    var left = 0
    var right = characters.size - 1

    while (left < right) {
        val temp = characters[left]
        characters[left] = characters[right]
        characters[right] = temp
        left++
        right--
    }

    return String(characters)
}
