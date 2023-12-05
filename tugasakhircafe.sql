-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 10 Jul 2022 pada 15.38
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tugasakhircafe`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `produk`
--

CREATE TABLE `produk` (
  `ID` int(11) NOT NULL,
  `Nama` varchar(1000) NOT NULL,
  `Harga` int(254) NOT NULL,
  `Jenis` varchar(1000) NOT NULL,
  `Stock` int(254) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `produk`
--

INSERT INTO `produk` (`ID`, `Nama`, `Harga`, `Jenis`, `Stock`) VALUES
(1, 'Black Coffe', 6000, 'Minuman', 30),
(2, 'Cappucinno', 10000, 'Minuman', 23),
(5, 'Ketang Goreng', 10000, 'Makanan', 25),
(6, 'Sosis Goreng', 7000, 'Makanan', 30),
(7, 'Takoyaki', 15000, 'Makanan', 30),
(8, 'Udang Goreng', 10000, 'Makanan', 40),
(9, 'Teriyaki', 10000, 'Makanan', 15),
(10, 'Salad', 6000, 'Makanan', 20),
(11, 'Mocaccino', 10000, 'Minuman', 25),
(12, 'Espresso', 8000, 'Minuman', 30),
(13, 'Caramel Latte', 15000, 'Minuman', 50),
(14, 'Americano', 5000, 'Minuman', 30),
(15, 'Syphon', 9000, 'Minuman', 25),
(16, 'Jus Alpukat', 10000, 'Minuman', 25),
(17, 'Jus Jambu', 10000, 'Minuman', 25),
(18, 'Jus Sirsak', 10000, 'Minuman', 25),
(19, 'Jus Melon', 10000, 'Minuman', 25);

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `ID` int(11) NOT NULL,
  `Nama` varchar(254) NOT NULL,
  `Jumlah_Beli` int(254) NOT NULL,
  `Harga_Satuan` int(254) NOT NULL,
  `Pembeli` varchar(254) NOT NULL,
  `Kasir_Pelayan` varchar(254) NOT NULL,
  `Waktu` date NOT NULL,
  `Total_Harga` int(254) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `transaksi`
--

INSERT INTO `transaksi` (`ID`, `Nama`, `Jumlah_Beli`, `Harga_Satuan`, `Pembeli`, `Kasir_Pelayan`, `Waktu`, `Total_Harga`) VALUES
(11, 'Black Coffe', 2, 5000, 'Kepin', 'Ren', '2022-07-08', 10000),
(12, 'Cappucinno', 2, 10000, 'Eden', 'ren', '2022-07-10', 20000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `pasword` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `user`
--

INSERT INTO `user` (`id`, `username`, `pasword`) VALUES
(1, 'Ren', 'qwert3214'),
(2, 'Ashbell', '1234');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `produk`
--
ALTER TABLE `produk`
  ADD PRIMARY KEY (`ID`);

--
-- Indeks untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`ID`);

--
-- Indeks untuk tabel `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `produk`
--
ALTER TABLE `produk`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT untuk tabel `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
