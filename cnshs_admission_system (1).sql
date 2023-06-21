-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 16, 2023 at 02:14 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cnshs_admission_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `applicant`
--

CREATE TABLE `applicant` (
  `lrn` varchar(12) NOT NULL,
  `fname` varchar(20) NOT NULL,
  `mname` varchar(20) NOT NULL,
  `lname` varchar(20) NOT NULL,
  `ext_name` varchar(5) DEFAULT NULL,
  `address` varchar(150) NOT NULL,
  `contact_num` varchar(15) NOT NULL,
  `school_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `applicant`
--

INSERT INTO `applicant` (`lrn`, `fname`, `mname`, `lname`, `ext_name`, `address`, `contact_num`, `school_name`) VALUES
('112145080008', 'John Erwin', 'Sayno', 'Albos', '', 'Panol Drive Purok - 1 Brgy. Camambugan Daet, Camarines Norte', '09126992952', 'Camarines Norte National High School'),
('21145080008', 'Juan', 'Dela', 'Cruz', '', 'Barangay Calasgasan Daet, Camarines Norte', '09126992952', 'Moreno Integrated School'),
('222145080008', 'Euriko', 'Eborde', 'Elagio', '', 'Barangay Calasgasan Daet, Camarines Norte', '09126992952', 'Moreno Integrated School');

-- --------------------------------------------------------

--
-- Table structure for table `applicant_acad_year`
--

CREATE TABLE `applicant_acad_year` (
  `lrn` varchar(20) NOT NULL,
  `section_id` int(11) NOT NULL,
  `acad_year` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `applicant_grade`
--

CREATE TABLE `applicant_grade` (
  `lrn` varchar(20) NOT NULL,
  `requirement_id` int(20) NOT NULL,
  `name` varchar(50) NOT NULL,
  `subject_grade` tinyint(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `applicant_grade`
--

INSERT INTO `applicant_grade` (`lrn`, `requirement_id`, `name`, `subject_grade`) VALUES
('112145080008', 1, 'Mathematics', 89),
('112145080008', 2, 'Science', 85),
('112145080008', 3, 'English', 89),
('21145080008', 4, 'Mathematics', 92),
('21145080008', 5, 'Science', 91),
('21145080008', 6, 'English', 90);

-- --------------------------------------------------------

--
-- Table structure for table `applicant_subject`
--

CREATE TABLE `applicant_subject` (
  `lrn` varchar(20) NOT NULL,
  `sub_num` int(11) NOT NULL,
  `schedule` time NOT NULL,
  `subject_grade` tinyint(11) DEFAULT NULL,
  `acad_year` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `exam`
--

CREATE TABLE `exam` (
  `exam_id` int(11) NOT NULL,
  `exam_sub` varchar(30) NOT NULL,
  `room` varchar(20) NOT NULL,
  `date` date NOT NULL,
  `time` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `exam`
--

INSERT INTO `exam` (`exam_id`, `exam_sub`, `room`, `date`, `time`) VALUES
(1, 'Science', '2', '2023-05-19', '10:30:00'),
(2, 'English', '3', '2023-05-20', '09:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `exam_result`
--

CREATE TABLE `exam_result` (
  `LRN` varchar(12) NOT NULL,
  `exam_id` int(11) NOT NULL,
  `exam_sub` varchar(50) NOT NULL,
  `result` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `requirements`
--

CREATE TABLE `requirements` (
  `requirement_id` int(20) NOT NULL,
  `name` varchar(20) DEFAULT NULL,
  `type` varchar(200) DEFAULT NULL,
  `GWA` tinyint(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `requirements`
--

INSERT INTO `requirements` (`requirement_id`, `name`, `type`, `GWA`) VALUES
(1, 'English', 'Birth Certificate,Form 138,Good Moral,NCAE', 86),
(2, 'Science', 'Birth Certificate,Form 138,Good Moral,NCAE', 86),
(3, 'Mathematics', 'Birth Certificate,Form 138,Good Moral,NCAE', 86),
(4, 'English', 'Birth Certificate,Form 138,Good Moral,NCAE', 91),
(5, 'Science', 'Birth Certificate,Form 138,Good Moral,NCAE', 91),
(6, 'Mathematics', 'Birth Certificate,Form 138,Good Moral,NCAE', 91);

-- --------------------------------------------------------

--
-- Table structure for table `section`
--

CREATE TABLE `section` (
  `section_id` int(20) NOT NULL,
  `section_name` varchar(20) NOT NULL,
  `room_num` int(10) NOT NULL,
  `grade_level` tinyint(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `section`
--

INSERT INTO `section` (`section_id`, `section_name`, `room_num`, `grade_level`) VALUES
(1, 'Resilience', 2, 11),
(2, 'Obedience', 1, 11),
(3, 'Punctuality', 3, 11);

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

CREATE TABLE `subject` (
  `sub_num` int(20) NOT NULL,
  `sub_name` varchar(50) NOT NULL,
  `sub_instructor` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `subject`
--

INSERT INTO `subject` (`sub_num`, `sub_name`, `sub_instructor`) VALUES
(1, 'Chemistry', 'Lo, Norman, Reyes'),
(2, 'EAPP', 'Magdasoc, Jobeth, Avellana'),
(3, 'MIL', 'Lim, Jenina, Sangcap');

-- --------------------------------------------------------

--
-- Table structure for table `teacher`
--

CREATE TABLE `teacher` (
  `teacher_id` int(11) NOT NULL,
  `teacher_name` varchar(150) NOT NULL,
  `teacher_designation` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `teacher`
--

INSERT INTO `teacher` (`teacher_id`, `teacher_name`, `teacher_designation`) VALUES
(1, 'Magdasoc, Jobeth, Avellana', 'SSG Coordinator'),
(2, 'Lim, Jenina, Sangcap', 'ICT Coordinator'),
(3, 'Lo, Norman, Reyes', 'Guidance');

-- --------------------------------------------------------

--
-- Table structure for table `validates_applicant`
--

CREATE TABLE `validates_applicant` (
  `teacher_id` int(11) NOT NULL,
  `requirement_id` int(11) NOT NULL,
  `remarks` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `applicant`
--
ALTER TABLE `applicant`
  ADD PRIMARY KEY (`lrn`);

--
-- Indexes for table `applicant_acad_year`
--
ALTER TABLE `applicant_acad_year`
  ADD PRIMARY KEY (`lrn`);

--
-- Indexes for table `applicant_grade`
--
ALTER TABLE `applicant_grade`
  ADD PRIMARY KEY (`lrn`,`requirement_id`);

--
-- Indexes for table `applicant_subject`
--
ALTER TABLE `applicant_subject`
  ADD PRIMARY KEY (`lrn`,`sub_num`);

--
-- Indexes for table `exam`
--
ALTER TABLE `exam`
  ADD PRIMARY KEY (`exam_id`);

--
-- Indexes for table `exam_result`
--
ALTER TABLE `exam_result`
  ADD PRIMARY KEY (`LRN`,`exam_id`);

--
-- Indexes for table `requirements`
--
ALTER TABLE `requirements`
  ADD PRIMARY KEY (`requirement_id`);

--
-- Indexes for table `section`
--
ALTER TABLE `section`
  ADD PRIMARY KEY (`section_id`);

--
-- Indexes for table `subject`
--
ALTER TABLE `subject`
  ADD PRIMARY KEY (`sub_num`);

--
-- Indexes for table `teacher`
--
ALTER TABLE `teacher`
  ADD PRIMARY KEY (`teacher_id`);

--
-- Indexes for table `validates_applicant`
--
ALTER TABLE `validates_applicant`
  ADD PRIMARY KEY (`teacher_id`,`requirement_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `exam`
--
ALTER TABLE `exam`
  MODIFY `exam_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `requirements`
--
ALTER TABLE `requirements`
  MODIFY `requirement_id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `section`
--
ALTER TABLE `section`
  MODIFY `section_id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `subject`
--
ALTER TABLE `subject`
  MODIFY `sub_num` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `teacher`
--
ALTER TABLE `teacher`
  MODIFY `teacher_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
