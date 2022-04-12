-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 03, 2021 at 04:06 AM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `blog_didin`
--

-- --------------------------------------------------------

--
-- Table structure for table `konten`
--

CREATE TABLE `konten` (
  `id` int(11) NOT NULL,
  `judul` varchar(255) NOT NULL,
  `isi` text NOT NULL,
  `tanggal` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `konten`
--

INSERT INTO `konten` (`id`, `judul`, `isi`, `tanggal`) VALUES
(1, 'Teknologi baru Biotechnology Technology plastic ditemukan di tong sampah', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus dapibus laoreet euismod. Aenean facilisis, leo a congue dictum, est sapien gravida quam, eu mattis mi quam id leo. Donec vel odio ullamcorper, pretium dui ac, consequat lorem. Praesent accumsan metus quis ligula vehicula imperdiet. Nam euismod sapien ac diam tristique accumsan. Praesent sollicitudin lectus metus, ut condimentum massa varius sed. Ut iaculis porta aliquet. Interdum et malesuada fames ac ante ipsum primis in faucibus. Maecenas eu consectetur mi, non lacinia massa. Duis sagittis eget elit a convallis. Etiam congue eget erat sit amet euismod. Fusce nibh neque, ultrices quis interdum vitae, blandit vitae lectus. Sed bibendum porta quam, congue vestibulum erat eleifend sed. Pellentesque semper odio vitae risus tincidunt, vel faucibus mauris aliquet. Nulla facilisi. Proin porttitor sapien nec lorem interdum, nec accumsan dui tincidunt.', '2021-07-02'),
(2, 'BTS plastik ramah lingkungan', 'Plastik wajib dibuang pada tempatnya ya teman teman', '2021-07-03');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `id` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id`, `password`) VALUES
('admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `konten`
--
ALTER TABLE `konten`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `konten`
--
ALTER TABLE `konten`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
