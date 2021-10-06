Feature: Calculator
    Calculator that can add to numbers

Scenario: AddTwoNumbers
    Given the number 15 as firstNumber
    And the number 12 as second number
    When i press add
    Then the result should show 27
