# Assignment 1

## 1. Reflections
### 1.1 Computer mouse
> Identify the types of testing you would perform on a computer mouse, to make sure that it is of the highest quality.
- Intensive clicking over longer time, on all the buttons
- USB testing different sockets and multiple times plugging in and out
- If Laser pointing, test laser and correct movement of cursor
- Scroll wheel testing, make sure it scrolls both ways
- Test Multiple buttons at once
- Test different DPI settings
- IF RGB, test different colors and brightness

### 1.2 Catastrophic Failure
> Find a story where a software system defect had a bad outcome. Describe what happened. Can you identify a test that would have prevented it?

Undetected hole in the ozone layer
> The hole in the ozone layer over Antarctica remained undetected for a long period of time because the data analysis software used by NASA in its project to map the ozone layer had been designed to ignore values that deviated greatly from expected measurements.

> The project had been launched in 1978, but it wasn’t until 1985 that the hole was discovered, and not by NASA. NASA didn’t find the error until they reviewed their data, which indeed showed that there was a big hole in the ozone layer.

This could propably have been avoided by writing a test, that had meassurements way higher than expected.


## 2. Two Katas
> Complete the following using TDD. Remember the TDD mantra

### 2.1 String Utility
- [String Utility Test](./assignment-02.Test/StringUtilityTest.cs)
- [String Utility Method](./assignment-02.Program/StringUtility.cs)

### 2.2 BowlingGame
- [BowlingGame Test](./assignment-02.Test/BowlingGameTest.cs)
- [BowlingGame Method](./assignment-02.Program/BowlingGame.cs)

### How to run
#### 1. Build Docker Image
```
docker build -t assignment-02 .
```
#### 2. Run Docker Image
```
docker run -it --rm assignment-02
```
#### Or use dotnet cli
```
dotnet test
```

## 3. Investigation of tools
### 3.1 JUnit 5
> Investigate JUnit 5 (Jupiter). Explain the following, and how they are useful.

`@Tag`
- Used to declare tags for filtering tests, either at the class or method level

`@Disabled`
- Used to disable a test class or test method.

`@RepeatedTest`
- Denotes that a method is a test template for a repeated test. Such methods are inherited unless they are overridden.

`@BeforeEach, @AfterEach`
- Denotes that the annotated method should be executed before or after each

`@BeforeAll, @AfterAll`
- Denotes that the annotated method should be executed before or after all

`@DisplayName`
- Declares a custom display name for the test class or test method. Such annotations are not inherited.

`@Nested`
- Denotes that the annotated class is a non-static nested test class.

`assumeFalse, assumeTrue`
- If called with an expression evaluating to true or false, the test will halt and be ignored.

### 3.2 Mocking Frameworks
> Investigate mocking frameworks for your preferred language. Choose at least two
frameworks, and answer the questions. (One could be Mockito, which we saw in class.)

For this comparison i have chosen Mockito and EasyMock.

#### What are their similarities?
 - Both build for Java
 - Both open-source projects
 - Both can mock Exception throwing
#### What are their differences?
 - Different licenses
 - Mockito is newer
 - Mockito will not fail a test if the return data is unmocked. It does this by returning a defualt data, like an empty list.
#### Which one would you prefer, if any, and why?
 - Mockito as it is made cause of lack of features in Easymock, and it also has a bigger userbase behind.