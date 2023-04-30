#MySQL
SELECT DISTINCT firstWeather.id
FROM Weather AS firstWeather,
     Weather AS secondWeather
WHERE datediff(firstWeather.recordDate, secondWeather.recordDate) = 1
  AND firstWeather.temperature > secondWeather.temperature