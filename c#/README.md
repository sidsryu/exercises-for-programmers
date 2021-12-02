# exercises-for-programmers

Exercises for Programmers : 57 Challenges to Develop Your Coding Skills, by Brian P. Hogan

## What did I learn

### Exercise 1. Saying Hello

- 보간 문자열
  ```c#
  $"Hello, {name}, nice to meet you!"
  ```
- 빈문자열 검사
  ```c#
  string.IsNullOrEmpty(name)
  ```
- 표준 입출력
  ```c#
  Console.Write("What is your name?");
  string hello = Console.ReadLine();
  ```
- NUnit 설치
  - NUnit : 유닛테스트 프레임워크
  - NUnit3TestAdapter : 비주얼 스튜디오 테스트창 연동
- NUnit TestFixture, Test 특성
  - TestFixture : 테스트 포함 클래스
  - Test : 테스트 메서드

### Exercise 2. Counting the Number of Characters

- 문자열 길이
  ```c#
  word.Length
  ```
- NUnit TestCase 특성
  - TestCase : 테스트에 사용할 데이터 제공
    ```c#
    [TestCase("Homer", "Homer has 5 characters.")]
    ```

### Exercise 3. Printing Quotes

- 없음

### Exercise 4. Mad Lib

- 구조체
- 개체 초기화
  ```c#
  var parts = new PartsOfSpeech()
  {
      Noun = "dog",
      Verb = "walk",
      Adjective = "blue",
      Adverb = "quickly"
  }
  ```
- 속성
  ```c#
  public string Noun { get; set; }
  ```
- 소스코드 긴 문자열 줄바꿈
  ```c#
  return "Do You ..." +
    "... hilarious!";
  ```

### Exercise 5. Simple Math

- 튜플
  ```c#
  (10, 5)
  ```
- 문자열 캐스팅
  ```c#
  int.TryParse(first, out f);
  ```

### Independent Study

- NuGet.Config
  - 모든 프로젝트의 NUnit을 공용으로 사용하기 위해 추가.
  - 드라이브 루트에서 현재 폴더(nuget.exe가 호출되는 위치 또는 비주얼 스튜디오 프로젝트 폴더)까지 이동하며 구성파일을 찾는다.
  - 프로젝트 또는 현재 폴더에 가장 가까운 설정부터 우선 적용. 누적 적용.

### Exercise 6. Retirement Calcculator

- 시간
  ```c#
  DateTime.Now
  ```
- 테스트 스텁

### Exercise 7. Area of a Rectangular Room

- NUnit Within 수식어
  ```c#
  Assert.That(sqm, Is.EqualTo(27.8709).Within(0.0001));
  ```

### Exercise 8. Pizza Party
  
- 람다
  ```c#
  () => PizzaDistributor.Distribute(peopleCount, pizzaCount, pizzaCuts);
  ```
- NUnit 예외 테스트
  ```c#
  ActualValueDelegate<object> del =
      () => PizzaDistributor.Distribute(peopleCount, pizzaCount, pizzaCuts);
  Assert.That(del, Throws.ArgumentException);
  ```

### Exercise 9. Paint Calculator

- 올림
  ```c#
  Math.Ceiling(liters);
  ```

### Exercise 10. Self-Checkout

- 자동 속성 초기화
  ```c#
  public OrderItem(double price, int cout)
  {
      this.Price = price;
      this.Count = count;
  }
  ```

### Exercise 11. Currency Conversion

- 반올림
  ```c#
  Math.Round(dollar, 2);
  ```

### Exercise 12. Computing Simple Interest

- 없음

### Exercise 13. Determining Compound Interest

- 거듭제곱
  ```c#
  Math.Pow(1 + 4 / n, n * t);
  ```

### Exercise 14. Tax Calculator

- 없음

### Exercise 15. Password Validation

- 딕셔너리
  ```c#
  Dictionary<string, string> listOfAccounts = new Dictionary<string, string>();
  ...
  listOfAccounts.ContainsKey(username);
  ```

### Exercise 16. Legal Driving Age

- 없음

### Exercise 17. Blood Alcohol Calculator

- 열거형
  ```c#
  public enum Sex
  {
      Male,
      Female,
  };
  ```

### Exercise 18. Temperature Converter

- 문자열 비교
  ```c#
  inputChoice.Equals("c", StringComparison.OrdinalIgnoreCase)
  ```
- Func 델리게이트
  ```c#
  Func<double, double> convert;
  ```

### Exercise 19. BMI Calculator

- 없음
