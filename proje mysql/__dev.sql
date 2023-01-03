-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 03 Oca 2023, 16:41:14
-- Sunucu sürümü: 8.0.30
-- PHP Sürümü: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `ödev`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `cesit`
--

CREATE TABLE `cesit` (
  `Id` int NOT NULL,
  `cesit` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `cesitid`
--

CREATE TABLE `cesitid` (
  `marka` varchar(50) NOT NULL,
  `Id` int NOT NULL,
  `cesitid` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanıcı`
--

CREATE TABLE `kullanıcı` (
  `Id` int NOT NULL,
  `isimsoyisim` varchar(50) NOT NULL,
  `telno` varchar(50) NOT NULL,
  `adres` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `kullanıcıadi` varchar(50) NOT NULL,
  `sifre` varchar(50) NOT NULL,
  `görev` varchar(50) NOT NULL,
  `resim` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ürünler`
--

CREATE TABLE `ürünler` (
  `Id` int NOT NULL,
  `çeşit` varchar(50) NOT NULL,
  `marka` varchar(50) NOT NULL,
  `fiyat` double NOT NULL,
  `VERGİ` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `cesit`
--
ALTER TABLE `cesit`
  ADD PRIMARY KEY (`Id`);

--
-- Tablo için indeksler `cesitid`
--
ALTER TABLE `cesitid`
  ADD PRIMARY KEY (`Id`);

--
-- Tablo için indeksler `kullanıcı`
--
ALTER TABLE `kullanıcı`
  ADD PRIMARY KEY (`Id`);

--
-- Tablo için indeksler `ürünler`
--
ALTER TABLE `ürünler`
  ADD PRIMARY KEY (`Id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `cesit`
--
ALTER TABLE `cesit`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `cesitid`
--
ALTER TABLE `cesitid`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `kullanıcı`
--
ALTER TABLE `kullanıcı`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `ürünler`
--
ALTER TABLE `ürünler`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
